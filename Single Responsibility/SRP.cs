public class PasswordHasher
{
    public String HashAndSavePassword(String password)
    {
        hashPassword();
        savePassword(); 
    }

    public void HashPassword()
    {
        //hashing implementation
    }
    public void SavePassword()
    {
        //save to the db
    }
}