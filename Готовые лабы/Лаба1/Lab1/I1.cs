namespace Lab1
{
    public delegate void ReturnName(string name);

    interface I1
    {
        string Name2 { get; set; }
        public void ReturnNames(string nms);
        public event ReturnName ReturnNameEvent;
        public C2 this[int index] { get; set; }
    }
}