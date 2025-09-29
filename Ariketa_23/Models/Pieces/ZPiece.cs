using Ariketa_23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_23.Models.Pieces
{
    internal class ZPiece : IPiece
    {
		private string[,] _Form = { 
			{   "[]",	"[]",	""		}, 
			{	"",		"[]",	"[]"	} 
		};

		public string[,] Form
		{
			get { return _Form; }
		}

		private int _Rotation;

		public int Rotation
		{
			get { return _Rotation; }
			set { _Rotation = value; }
		}

        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
