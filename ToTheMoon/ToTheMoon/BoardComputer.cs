namespace ToTheMoon
{
    public class BoardComputer
    {
        public int BoardComputerID { get; set; }
        public AI AI = new AI(5005);

        public BoardComputer(int boardComputerID)
        {
            BoardComputerID = boardComputerID;
        }
    }
}
