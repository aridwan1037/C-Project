internal class Program
{
    private static void Main(string[] args)
    {
        Zoo zoo = new Zoo();
        zoo.Animals.Add(new Animal("Kangaroo", 10));
        zoo.Animals.Add(new Animal("Mr Sea Lion", 20));
        Console.WriteLine(zoo.Animals[0].Popularity);
        Console.WriteLine(zoo.Animals["Mr Sea Lion"].Popularity);
        zoo.Animals["Kangaroo"].Name = "Mr Roo";
        Console.WriteLine(zoo.Animals["Mr Roo"].Popularity);
    }
    public class Animal
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (Zoo != null) Zoo.Animals.NotifyNameChange(this, value);
                name = value;
            }
        }
        public int Popularity;
        public Zoo Zoo { get; internal set; }
        public Animal(string name, int popularity)
        {
            Name = name; Popularity = popularity;
        }
    }
    public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>{
    // ...
protected abstract TKey GetKeyForItem(TItem item);
    protected void ChangeItemKey(TItem item, TKey newKey);
    // Fast lookup by key - this is in addition to lookup by index.
    public TItem this[TKey key] { get; }
    protected IDictionary<TKey, TItem> Dictionary { get; }
}
public class AnimalCollection : KeyedCollection<string, Animal>
{
    Zoo zoo;
    public AnimalCollection(Zoo zoo) { this.zoo = zoo; }
    internal void NotifyNameChange(Animal a, string newName) =>
    this.ChangeItemKey(a, newName);
    protected override string GetKeyForItem(Animal item) => item.Name;
    // The following methods would be implemented as in the previous example
    // protected override void InsertItem (int index, Animal item)...
    // protected override void SetItem (int index, Animal item)...
    // protected override void RemoveItem (int index)...
    // protected override void ClearItems()...
}
public class Zoo
{
    public readonly AnimalCollection Animals;
    public Zoo() { Animals = new AnimalCollection(this); }
}
}
