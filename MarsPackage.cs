using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class MarsPackage : ValidationResult
    {
        /// <summary>
        /// Sınır Koordinatları
        /// </summary>
        public List<char> PlateauBorder { get; set; }

        /// <summary>
        /// Gezgin Koordinat ve Yön Bilgileri
        /// </summary>
        public Mover MoverInformation { get; set; }

        /// <summary>
        /// Komut
        /// </summary>
        public List<char> Command { get; set; }

    }

    internal class Mover 
    {
        public List<char> MoverCoordinate { get; set; }

        public char MoverDirection { get; set; }
    }
}
