using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class MarsRoverValidation
    {
        const string ErrorHeader = "Girdi Hatalı! Format aşağıdaki şekilde olmalıdır. \n";
        const string ErrorPlateauBorderInput = "1.Satır: Plato Sınır Bilgileri (Örn: 55) ";
        const string ErrorMoverCoordinateInput = "2.Satır: Gezgin Koordinat ve Yön Bilgileri (Örn: 12 N) ";
        const string ErrorCommandInput = "3.Satır: Komut Bilgileri (Örn: LMLMLMLMM) ";

        /// <summary>
        /// Gezginin platoda ayrılan alan içerisinde kalıp kalmadığını kontrol eder.
        /// </summary>
        /// <param name="plateauBorder"></param>
        /// <param name="moverInformation"></param>
        /// <returns></returns>
        public static ValidationResult ValidateBorder(List<char> plateauBorder, Mover moverInformation)
        {
            ValidationResult validationResult = new ValidationResult();
            string errorMessage = "";
            bool isSuccessful = true;
            short plateauBorderX = (short)plateauBorder.First();
            short plateauBorderY = (short)plateauBorder.Last();
            short plateauBorderXMin = 48; // 0 koordinatı 48 ile temsil ediliyor.
            short plateauBorderYMin = 48; // 0 koordinatı 48 ile temsil ediliyor.

            if (moverInformation.MoverCoordinate.First() < plateauBorderXMin || moverInformation.MoverCoordinate.First() > plateauBorderX)
            {
                errorMessage = "Gezgin X ekseninde sınır dışına çıkmaktadır. Harekete izin verilemez";
                isSuccessful = false;
            }
            if (moverInformation.MoverCoordinate.Last() < plateauBorderYMin || moverInformation.MoverCoordinate.Last() > plateauBorderY)
            {
                errorMessage += "Gezgin Y ekseninde sınır dışına çıkmaktadır. Harekete izin verilemez.";
                isSuccessful = false;
            }

            validationResult.IsSuccessful = isSuccessful;
            validationResult.ErrorMessage = errorMessage;
            return validationResult;
        }

        /// <summary>
        /// Girilen bilgileri valide eder.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static ValidationResult ValidateInputLines(string[] lines)
        {
            ValidationResult validationResult = new ValidationResult();
            lines = lines.Where(w => w != "").ToArray();
            ValidationResult resultValidateLineCount = ValidateLineCount(lines, validationResult);
            if (!resultValidateLineCount.IsSuccessful)
            {
                validationResult = resultValidateLineCount;
                return validationResult;
            }

            ValidationResult resultValidatePlateauBorder = ValidatePlateauBorder(lines[0]);
            ValidationResult resultValidateMoverCoordinate = ValidateMoverCoordinate(lines[1]);
            ValidationResult resultValidateCommand = ValidateCommand(lines[2]);


            validationResult.IsSuccessful = resultValidatePlateauBorder.IsSuccessful && resultValidateMoverCoordinate.IsSuccessful && resultValidateCommand.IsSuccessful;
            validationResult.ErrorMessage = String.Concat(resultValidatePlateauBorder.ErrorMessage, resultValidateMoverCoordinate.ErrorMessage, resultValidateCommand.ErrorMessage);

            if (validationResult.IsSuccessful) //Diğerlerinin başarılı olması durumunda bu kontrol yapılacak.
                validationResult = ValidateRoverBorder(lines, validationResult);
            return validationResult;

        }

        /// <summary>
        /// Girdi satır sayısı kontrolü
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="vr"></param>
        /// <returns></returns>
        public static ValidationResult ValidateLineCount(string[] lines, ValidationResult vr)
        {
            bool isSuccessful = true;
            string errorMessage = "";

            if (lines.Count() != 3)
            {
                errorMessage = String.Format("Girdi 3 satırdan oluşmalı! \n{0} \n{1} \n{2}", ErrorPlateauBorderInput, ErrorMoverCoordinateInput, ErrorCommandInput);
                isSuccessful = false;
            }

            vr.IsSuccessful = isSuccessful;
            vr.ErrorMessage = errorMessage;
            return vr;
        }

        /// <summary>
        /// Plato alan bilgilerini valide eder. (1. Satır)
        /// </summary>
        /// <param name="plateauBorderInfo"></param>
        /// <returns></returns>
        public static ValidationResult ValidatePlateauBorder(string plateauBorderInfo)
        {
            ValidationResult vr = new ValidationResult();
            bool isSuccessful = true;
            string errorMessage = "";
            plateauBorderInfo = plateauBorderInfo.Trim().Replace(" ","");
            
            if (plateauBorderInfo.Length != 2 || !Int16.TryParse(plateauBorderInfo, out _))
            {
                isSuccessful = false;
                errorMessage = String.Concat(ErrorHeader, ErrorPlateauBorderInput,"\n");
            }
            else if (plateauBorderInfo == "00" || Convert.ToInt16(plateauBorderInfo) < 0)
            {
                isSuccessful = false;
                errorMessage = "Alan sınırları (0,0) veya daha küçük verilemez. \n";
            }

            vr.IsSuccessful = isSuccessful;
            vr.ErrorMessage = errorMessage;
            return vr;
        }

        /// <summary>
        /// Gezginin bilgilerini valide eder. (2. Satır)
        /// </summary>
        /// <param name="moverCoordinateInfo"></param>
        /// <returns></returns>
        public static ValidationResult ValidateMoverCoordinate(string moverCoordinateInfo)
        {
            ValidationResult vr = new ValidationResult();
            bool isSuccessful = true;
            string errorMessage = "";
            List<char> directionList = new List<char> { 'N', 'S', 'E', 'W' };
            moverCoordinateInfo = moverCoordinateInfo.Trim();
            char directionLetter = moverCoordinateInfo.LastOrDefault();
            moverCoordinateInfo = moverCoordinateInfo.Replace(" ", "");

            if (moverCoordinateInfo.Length!=3 || !Int16.TryParse(moverCoordinateInfo.Substring(0, 2), out _) || !directionList.Contains(directionLetter))
            {
                isSuccessful = false;
                errorMessage = String.Concat(ErrorHeader, ErrorMoverCoordinateInput, "\n");
            }

            vr.IsSuccessful = isSuccessful;
            vr.ErrorMessage = errorMessage;
            return vr;
        }

        /// <summary>
        /// Komut bilgilerini valide eder. (3.Satır)
        /// </summary>
        /// <param name="commandInfo"></param>
        /// <returns></returns>
        public static ValidationResult ValidateCommand(string commandInfo)
        {
            ValidationResult vr = new ValidationResult();
            bool isSuccessful = true;
            string errorMessage = "";
            List<char> commandList = new List<char> { 'L', 'R', 'M' };
            commandInfo = commandInfo.Trim().Replace(" ","");
            char[] commandCharacters = commandInfo.ToCharArray();

            foreach (var item in commandCharacters)
            {
                if (!commandList.Contains(item))
                {
                    isSuccessful = false;
                    errorMessage = String.Concat(ErrorHeader, ErrorCommandInput, "\n");
                    break;
                }

            }

            vr.IsSuccessful = isSuccessful;
            vr.ErrorMessage = errorMessage;
            return vr;
        }

        /// <summary>
        /// Gezginin sınırlar içerisinde olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="vr"></param>
        /// <returns></returns>
        public static ValidationResult ValidateRoverBorder(string[] lines, ValidationResult vr)
        {
            bool isSuccessful = true;
            string errorMessage = "";

            short plateauBorderX = (short)lines[0].Trim().First();
            short plateauBorderY = (short)lines[0].Trim().Last();
            short roverCoordinateX = (short)lines[1].Trim().First();
            short roverCoordinateY = (short)lines[1].Trim()[1];

            if (roverCoordinateX > plateauBorderX || roverCoordinateY > plateauBorderY)
            {
                isSuccessful = false;
                errorMessage = "Gezginin konumu alan dışında olamaz. Girdiyi kontrol ediniz.";
            }

            vr.IsSuccessful = isSuccessful;
            vr.ErrorMessage = errorMessage;
            return vr;
        }

    }

    internal class ValidationResult
    {
        internal bool IsSuccessful { get; set; }
        internal string ErrorMessage { get; set; }
    }
}
