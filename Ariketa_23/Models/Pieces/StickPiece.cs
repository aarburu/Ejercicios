using Ariketa_23.Interfaces;

namespace Ariketa_23.Models.Pieces
{
    internal class StickPiece : IPiece
    {
		private string[,] _Form = { 
			{	"[]"	}, 
			{	"[]"	}, 
			{	"[]"	}, 
			{	"[]"	}
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
