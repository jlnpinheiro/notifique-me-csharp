namespace JNogueira.NotifiqueMe.Test;
public class ValidacoesBooleanTests : Notificavel
{
    [Test]
    [Category("Boolean")]
    public void Deve_Notificar_Se_Verdadeiro()
    {
        var valor = true;

        this.NotificarSeVerdadeiro(valor, "O valor é verdadeiro.", id: "ERR001");

        Assert.That(Invalido);
    }

    [Test]
    [Category("Boolean")]
    public void Deve_Notificar_Se_Falso()
    {
        var valor = false;

        this.NotificarSeFalso(valor, "O valor é false.", id: "ERR002");

        Assert.That(Invalido);
    }
}
