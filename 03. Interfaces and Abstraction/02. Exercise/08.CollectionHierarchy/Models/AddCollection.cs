using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : IAddElements       
    {
        protected List<string> _collection;

        public AddCollection() 
        {
        _collection = new List<string>();
        }

        public virtual int Add(string input)
        {
          _collection.Add(input);
          return _collection.Count - 1;
        }
    }
}
