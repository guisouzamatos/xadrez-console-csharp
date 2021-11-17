namespace xadrez_console.table
{
    internal class Piece
    {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moves { get; protected set; }
        public Table tab { get; protected set; }

        public Piece(Position position, Table table, Color color)
        {
            this.position = position;
            this.tab = table;   
            this.color = color;
            this.moves = 0;
        }
    }
}
