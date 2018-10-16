public class Dog{

    string breed;

    public Dog(string breed){
        this.Breed = breed;
    }

    public string Breed
    {
        get
        {
            return breed;
        }

        set
        {
            breed = value;
        }
    }
}
