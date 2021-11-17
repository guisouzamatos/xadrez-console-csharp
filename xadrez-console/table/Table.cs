using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.table
{
    internal class Table
    {

        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Table(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }
    }
}
