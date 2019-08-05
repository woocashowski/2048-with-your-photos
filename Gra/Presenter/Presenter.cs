namespace Game.Presenter
{
    class Presenter
    {
        //public uint[,] vs;
        Game.Model.Logic model;
        Game.View.IBoard view;

        public Presenter(Game.Model.Logic model, Game.View.IBoard view)
        {
            this.model = model;
            this.view = view;

            view.MoveTable += View_MoveTable;
        }

        private uint[,] View_MoveTable(uint[,] arg1, char arg2)
        {
            return model.MoveTable(arg1, arg2);
        }


        //public uint[,] MoveTable(uint[,] Tab, char Move)
        public uint[,] MoveTable(uint[,] Tab, char Move)
        {
            return model.MoveTable(Tab, Move);
        }


        /*
        public PresenterTC(Models.ModelTC model, Views.IViewTC view)
        {
            this.model = model;
            this.view = view;
            view.GetDrives += getDrives;
            view.GetItems += getItems;
            view.GetPath += getPath;
            view.GetParent += getParent;
            view.Copy += copyFile;
            view.Delete += deleteFile;
            view.Move += moveFile;
        }
        */
        //Model.Model model;
        //Views.IViewTC view;
    }
}
