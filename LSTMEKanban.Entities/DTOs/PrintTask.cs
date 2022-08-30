namespace LSTMEKanban.Entities.DTOs
{
    public class PrintTask
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "URL")]
        public string Url { get; set; } = string.Empty;

        public State CurrentState { get; set; }

        [Display(Name = "Notes")]
        public string Notes = string.Empty;

        public DateTime CreateDateTime { get; set; }
        
        public PrintTask() : this(string.Empty, string.Empty, State.Ready) { }

        public PrintTask(string name, string url, State currentState)
        {
            Name = name;
            Url = url;
            CurrentState = currentState;
        }
        
        public void UpdateState(State newState)
        {
            CurrentState = newState; 
        }
    }
}
