namespace Task1EnvelopeAnalysis
{
    public class Envelope
    {
        
        public Envelope(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public static bool operator >(Envelope envelope1, Envelope envelope2)
        {
            bool putInside = ((envelope1.Height>envelope2.Height)&&(envelope1.Width> envelope2.Width))
                            ||((envelope1.Height>envelope2.Width)&&(envelope1.Width>envelope2.Height));

            return putInside;
        }
        
        public static bool operator <(Envelope envelope1, Envelope envelope2)
        {
            return envelope2 > envelope1;
        }
        
        
        public double Width { get; set; }
        public double Height { get; set; }
    }
}