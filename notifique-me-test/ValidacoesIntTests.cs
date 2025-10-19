namespace JNogueira.NotifiqueMe.Test;
public class ValidacoesIntTests : Notificavel
{
    #region MaiorQue
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Que_Decimal()
    {
        decimal valor1 = 2;
        int valor2 = 1;

        this.NotificarSeMaiorQue(valor1, valor2, "O valor 1 é maior que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Que_Double()
    {
        double valor1 = 2;
        int valor2 = 1;

        this.NotificarSeMaiorQue(valor1, valor2, "O valor 1 é maior que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Que_Float()
    {
        float valor1 = 2;
        int valor2 = 1;

        this.NotificarSeMaiorQue(valor1, valor2, "O valor 1 é maior que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Que_Int()
    {
        int valor1 = 2;
        int valor2 = 1;

        this.NotificarSeMaiorQue(valor1, valor2, "O valor 1 é maior que o valor 2.");

        Assert.That(Invalido);
    }
    #endregion

    #region MaiorOuIgualA
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Ou_Igual_A_Decimal()
    {
        decimal valor1 = 2;
        int valor2 = 2;

        this.NotificarSeMaiorOuIgualA(valor1, valor2, "O valor 1 é maior ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Ou_Igual_A_Double()
    {
        double valor1 = 2;
        int valor2 = 2;

        this.NotificarSeMaiorOuIgualA(valor1, valor2, "O valor 1 é maior ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Ou_Igual_A_Float()
    {
        float valor1 = 2;
        int valor2 = 2;

        this.NotificarSeMaiorOuIgualA(valor1, valor2, "O valor 1 é maior ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Maior_Ou_Igual_A_Int()
    {
        int valor1 = 2;
        int valor2 = 2;

        this.NotificarSeMaiorOuIgualA(valor1, valor2, "O valor 1 é maior ou igual ao valor 2.");

        Assert.That(Invalido);
    }
    #endregion

    #region MenorQue
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Que_Decimal()
    {
        decimal valor1 = (decimal)1.2;
        int valor2 = 2;

        this.NotificarSeMenorQue(valor1, valor2, "O valor 1 é menor que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Que_Double()
    {
        double valor1 = 1.2;
        int valor2 = 2;

        this.NotificarSeMenorQue(valor1, valor2, "O valor 1 é menor que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Que_Float()
    {
        float valor1 = (float)1.2;
        int valor2 = 2;

        this.NotificarSeMenorQue(valor1, valor2, "O valor 1 é menor que o valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Que_Int()
    {
        int valor1 = 1;
        int valor2 = 2;

        this.NotificarSeMenorQue(valor1, valor2, "O valor 1 é menor que o valor 2.");

        Assert.That(Invalido);
    }
    #endregion

    #region MenorOuIgualA
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Ou_Igual_A_Decimal()
    {
        decimal valor1 = (decimal)1.2;
        int valor2 = 2;

        this.NotificarSeMenorOuIgualA(valor1, valor2, "O valor 1 é menor ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Ou_Igual_A_Double()
    {
        double valor1 = 1.2;
        int valor2 = 2;

        this.NotificarSeMenorOuIgualA(valor1, valor2, "O valor 1 é menor ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Ou_Igual_A_Float()
    {
        float valor1 = (float)1.2;
        int valor2 = 2;

        this.NotificarSeMenorOuIgualA(valor1, valor2, "O valor 1 é menor ou igual ao valor 2.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Menor_Ou_Igual_A_Int()
    {
        int valor1 = 1;
        int valor2 = 2;

        this.NotificarSeMenorOuIgualA(valor1, valor2, "O valor 1 é menor ou igual ao valor 2.");

        Assert.That(Invalido);
    }
    #endregion

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Entre()
    {
        int valor = 2;
        int valor1 = 1;
        int valor2 = 3;

        this.NotificarSeEntre(valor, valor1, valor2, "O valor está entre os valores 1 e 3.");

        Assert.That(Invalido);
    }

    #region Iguais
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Iguais_Decimal()
    {
        decimal valor1 = 1;
        int valor2 = 1;

        this.NotificarSeIguais(valor1, valor2, "O valor 1 e o valor 2 são iguais.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Iguais_Double()
    {
        double valor1 = 1;
        int valor2 = 1;

        this.NotificarSeIguais(valor1, valor2, "O valor 1 e o valor 2 são iguais.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Iguais_Float()
    {
        float valor1 = 1;
        int valor2 = 1;

        this.NotificarSeIguais(valor1, valor2, "O valor 1 e o valor 2 são iguais.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Iguais_Int()
    {
        int valor1 = 1;
        int valor2 = 1;

        this.NotificarSeIguais(valor1, valor2, "O valor 1 e o valor 2 são iguais.");

        Assert.That(Invalido);
    }
    #endregion

    #region Diferentes
    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Diferentes_Decimal()
    {
        decimal valor1 = 1;
        int valor2 = 2;

        this.NotificarSeDiferentes(valor1, valor2, "O valor 1 e o valor 2 são diferentes.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Diferentes_Double()
    {
        double valor1 = 1;
        int valor2 = 2;

        this.NotificarSeDiferentes(valor1, valor2, "O valor 1 e o valor 2 são diferentes.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Diferentes_Float()
    {
        float valor1 = 1;
        int valor2 = 2;

        this.NotificarSeDiferentes(valor1, valor2, "O valor 1 e o valor 2 são diferentes.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Int")]
    public void Deve_Notificar_Se_Diferentes_Int()
    {
        int valor1 = 1;
        int valor2 = 2;

        this.NotificarSeDiferentes(valor1, valor2, "O valor 1 e o valor 2 são diferentes.");

        Assert.That(Invalido);
    }
    #endregion
}
