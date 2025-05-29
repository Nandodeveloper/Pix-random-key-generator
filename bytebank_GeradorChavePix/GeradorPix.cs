namespace bytebank_GeradorChavePix;

/// <summary>
/// Class that generates random PIX keys using the Guid format.
/// </summary>
public static class GeradorPix
{
    /// <summary>
    /// Method that returns a random PIX key.
    /// </summary>
    /// <returns>Returns a PIX key in String format.</returns>
    public static string GetChavePix() => Guid.NewGuid().ToString();

    /// <summary>
    /// Method that returns a list of random PIX keys.
    /// </summary>
    /// <param name="numeroChaves"> Number of keys to be generated.</param>
    /// <returns>List of PIX key strings.</returns>
    public static List<string> GetChavesPix(int numeroChaves) 
    {
        if (numeroChaves <= 0)
        {
            return null;
        }
        else
        {
            var chaves = new List<string>();
            for (int i = 0; i < numeroChaves; i++)
            {
                chaves.Add(Guid.NewGuid().ToString());
            }

            return chaves;
        } 
    }
}
