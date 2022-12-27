public class T_shirts
{
    public enum T_shirtsType { Small, Medium, Large, ExtraLarge}
    private string T_Shirts { get; }
    private T_shirtsType T_ShirtsType { get; }

    public T_shirts(T_shirtsType shirtsType, string shirts)
    {
        T_Shirts = shirts;
        T_ShirtsType = shirtsType;
    }

    public override string ToString()
    {
        return T_Shirts;
    }
}