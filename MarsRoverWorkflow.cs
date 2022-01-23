using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class MarsRoverWorkflow
    {
        /// <summary>
        /// Ekrandan girilen bilgileri işlemek için paketi hazırlar.
        /// </summary>
        internal static MarsPackage PreparePackage(string[] lines)
        {
            MarsPackage inputPackage = new MarsPackage();
            Mover moverInformation = new Mover();

            inputPackage.PlateauBorder = lines[0].Trim().Replace(" ","").ToCharArray().ToList();
            moverInformation.MoverCoordinate = lines[1].Trim().Replace(" ", "").ToCharArray().Take(2).ToList();
            moverInformation.MoverDirection = lines[1].Trim().ToCharArray().Last();
            inputPackage.MoverInformation = moverInformation;
            inputPackage.Command = lines[2].Trim().Replace(" ", "").ToCharArray().ToList();

            return inputPackage;
        }

        /// <summary>
        /// Gezgini haraket ettirir.
        /// </summary>
        internal static MarsPackage MoveRover(MarsPackage marsPackage)
        {
            List<char> plateauBorderInformation = marsPackage.PlateauBorder;
            Mover moverInformation = marsPackage.MoverInformation;
            List<char> commands = marsPackage.Command;

            foreach (var command in commands)
            {
                if (command != (char)Command.Move)
                    moverInformation = ChangeDirection(moverInformation, (Command)command);
                else
                {
                    moverInformation = Move(moverInformation);
                    var validationResult = MarsRoverValidation.ValidateBorder(plateauBorderInformation, moverInformation);
                    if (!validationResult.IsSuccessful)
                    {
                        marsPackage.IsSuccessful = validationResult.IsSuccessful;
                        marsPackage.ErrorMessage = validationResult.ErrorMessage;
                        return marsPackage;
                    }
                }
            }

            marsPackage.MoverInformation = moverInformation;
            marsPackage.IsSuccessful = true;
            return marsPackage;

        }

        /// <summary>
        /// Gezgini hareket ettirir.
        /// </summary>
        /// <param name="moverInformation"></param>
        /// <returns></returns>
        private static Mover Move(Mover moverInformation)
        {
            short moverCoordinateX = (short)moverInformation.MoverCoordinate.FirstOrDefault(); 
            short moverCoordinateY = (short)moverInformation.MoverCoordinate.LastOrDefault();

            Enum.TryParse(moverInformation.MoverDirection.ToString(), out Direction direction);

            switch (direction)
            {
                case Direction.W:
                    moverCoordinateX--;
                    break;
                case Direction.N:
                    moverCoordinateY++;
                    break;
                case Direction.E:
                    moverCoordinateX++;
                    break;
                case Direction.S:
                    moverCoordinateY--;
                    break;
                default:
                    break;
            }
            moverInformation.MoverCoordinate[0] = (char)moverCoordinateX;
            moverInformation.MoverCoordinate[1] = (char)moverCoordinateY;

            return moverInformation;
        }

        /// <summary>
        /// Yönü tayin eder.
        /// </summary>
        /// <param name="moverInformation"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static Mover ChangeDirection(Mover moverInformation, Command command)
        {
            // W: 0            // N: 1            // E: 2            // S :3
            Enum.TryParse(moverInformation.MoverDirection.ToString(), out Direction direction);

            if (command == Command.Left)
                moverInformation.MoverDirection = Convert.ToChar(((Direction)(((short)direction - 1) < 0 ? (short)direction + 3 : (short)direction - 1)).ToString());
            else if (command == Command.Right)
                moverInformation.MoverDirection = Convert.ToChar(((Direction)(((short)direction + 1) > 3 ? (short)direction - 3 : (short)direction + 1)).ToString());


            return moverInformation;
        }

    }


}
