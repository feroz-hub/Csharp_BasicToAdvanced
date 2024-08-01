namespace IndexerClassLibrary;

public class Car
{
    //private
    private string[] _brands = ["BMW", "Skoda", "Honda"];

    private string[] _names = ["First", "Second", "Third"];
    //public
    public string this[int index]
    {
        set{
            this._brands[index] = value;
        }
        get{
            return _brands[index];
        }
        
    }
    
    //indexer overloading
    public string this[string name]
    {
        set
        {
            this._brands[Array.IndexOf(_names, name)] = value;
            
        }
        get
        {
            return _brands[Array.IndexOf(_names, name)];
        }
    }
}