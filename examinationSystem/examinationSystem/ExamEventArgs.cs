namespace examinationSystem
{
    public class ExamEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public DateTime Timestamp { get; private set; }

        public ExamEventArgs(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
        }
    }

}
