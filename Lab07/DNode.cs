namespace Lab06;


public class DNode<T> 
{
    public T Value { get; set; }
    public DNode<T>? Previous { get; set; }
    public DNode<T>? Next { get; set; }

    public DNode(T Value, DNode<T> Previous, DNode<T> Next)
    {
        this.Value = Value;
        this.Previous = Previous;
        this.Next = Next;
    }
}