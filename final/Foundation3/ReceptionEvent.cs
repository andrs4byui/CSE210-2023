class ReceptionEvent : Event{
    private string _invitationEmail;

    public ReceptionEvent(string eventType, string eventTitle, string description, string date, string time, string invitationEmail) : base(eventType, eventTitle, description, date, time)
    {
        _invitationEmail = invitationEmail;
    }

    public string InvitationEmail { get => _invitationEmail; set => _invitationEmail = value; }
    public void DisplayEmailInvitation(){
        Console.WriteLine($"{_invitationEmail}");
    }

    public void FullDetails(){
        StandardDetails();
        DisplayEmailInvitation();
    }
}