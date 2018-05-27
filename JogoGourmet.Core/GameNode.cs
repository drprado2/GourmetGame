namespace JogoGourmet.Core
{
    public class GameNode
    {
        private string _label;
        private GameNode _leftNode;
        private GameNode _rightNode;

        public GameNode(string label)
        {
            _label = label;
        }
        
        public string Label
        {
            get { return _label; }
        }

        public GameNode LeftNode
        {
            get
            {
                return _leftNode;
            }
            set
            {
                value.FatherNode = this;
                _leftNode = value;
            }
        }
        
        public GameNode RightNode
        {
            get
            {
                return _rightNode;
            }
            set
            {
                value.FatherNode = this;
                _rightNode = value;
            }
        }

        public GameNode FatherNode { get; set; }
    }
}