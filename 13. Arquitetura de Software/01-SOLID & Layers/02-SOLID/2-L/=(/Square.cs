public class Square : Rectangle
{
    public override int Largura {
        set { base.Largura = base.Altura = value; }
    }
}