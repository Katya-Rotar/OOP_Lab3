internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int M = int.Parse(Console.ReadLine());
        List<Rectangle> rectangles = new List<Rectangle>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string id  = input[0];
            int width = int.Parse(input[1]);
            int height = int.Parse(input[2]);
            int x = int.Parse(input[3]);
            int y = int.Parse(input[4]);
            Rectangle rectangle = new Rectangle(id, width, height, x, y);
            rectangles.Add(rectangle);
        }
        for(int i = 0; i < M; i++) {
            string[] inpnt_2 = Console.ReadLine().Split();
            string id_1 = inpnt_2[0];
            string id_2 = inpnt_2[1];
            
            int id1 = 0, id2 = 0;
            for(int j = 0; j < rectangles.Count; j++) {
                if (rectangles[i].Id == id_1) { id1 = j;}
                if (rectangles[i].Id == id_2) { id2 = j;}
            }
            bool intersection = rectangles[id1].IntersectionCheck(rectangles[id2]);
            Console.WriteLine(intersection);
        }
    }
}
class Rectangle {
    public string Id;
    public int Width;
    public int Height;
    public int X;
    public int Y;

    public Rectangle(string id, int width, int height, int x, int y)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.X = x;
        this.Y = y;
    }
    public bool IntersectionCheck(Rectangle rectangle) {
        bool intersection = false;
        if ((X < rectangle.X + rectangle.Width) && (X + Width > rectangle.X) && (Y < rectangle.Y + rectangle.Height) && (Y + Height > rectangle.Y)) {
            intersection = true;
        }
        return intersection;
    }
}