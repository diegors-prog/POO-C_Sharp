namespace AP2_POO.ViewModels
{
  public class ClienteUpdateViewModel
  {
    public ClienteUpdateViewModel(string email, string fone)
    {
      this.Email = email;
      this.Fone = fone;
    }

    public ClienteUpdateViewModel()
    {

    }
    public string Email { get; set; }
    public string Fone { get; set; }
  }
}