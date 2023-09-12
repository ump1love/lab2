using System;

class User
{
    private string m_login;
    private string m_username;
    private int m_age;
    private DateTime m_dateOfCreation;

    public User(string login, string username, int age)
    {
        m_login = login;
        m_username = username;
        m_age = age;
        m_dateOfCreation = DateTime.Now;
    }

    public void displayUser()
    {
        Console.WriteLine($"Login: {m_login}");
        Console.WriteLine($"Username: {m_username}");
        Console.WriteLine($"Age: {m_age}");
        Console.WriteLine($"Date of creation: {m_dateOfCreation}");
    }

}