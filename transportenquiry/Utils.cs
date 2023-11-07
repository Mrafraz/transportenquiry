namespace transportenquiry
{
    public static class Utils
    {
        public static int GetTextHeight(RichTextBox rtb)
        {
            using (Graphics g = rtb.CreateGraphics())
            {
                SizeF size = g.MeasureString(rtb.Text,rtb.Font,495);
                return(int)Math.Ceiling(size.Height);

            }
        
        }
    }
}