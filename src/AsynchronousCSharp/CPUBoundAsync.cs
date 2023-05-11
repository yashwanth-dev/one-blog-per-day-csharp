using System.Threading.Channels;

namespace AsynchronousCSharp;

public class CPUBoundAsync
{
    public async Task<string> CalculateDamageDone()
    {
        var damageResult = await Task.Run(() => CalculateDamage());
        return "Damage done calculation completed: "+ damageResult;
    }
    
    public async Task<int> CalculateDamage()
    {
        await Task.Delay(1000);
        return 10;
    }
    
}