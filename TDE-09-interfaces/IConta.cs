namespace TDE_09_interfaces
{
    public interface IConta
    {
         void depositar(double valor);
        string sacar(double valor);
        string getSaldo();
    }
}