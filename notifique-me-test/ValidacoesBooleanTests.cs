namespace JNogueira.NotifiqueMe.Test;
public class ValidacoesBooleanTests : Notificavel
{
    [Test]
    [Category("Boolean")]
    public void Deve_Notificar_Se_Verdadeiro()
    {
        var valor = true;

        this.NotificarSeVerdadeiro(valor, "O valor é verdadeiro.");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Boolean")]
    public void Deve_Notificar_Se_Falso()
    {
        var valor = false;

        this.NotificarSeFalso(valor, "O valor é false.");

        Assert.That(Invalido);
    }
}
