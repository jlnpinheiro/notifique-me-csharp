using System.Linq;

namespace JNogueira.NotifiqueMe
{
    /// <summary>
    /// Classe responsável por adicionar notificações, caso uma determinada regra seja satisfeita.
    /// </summary>
    public static partial class Notificar
    {
        public static Notificavel Juntar(this Notificavel notificavel, params Notificavel[] notificaveis)
        {
            if (notificavel == null)
                return null;

            if (notificaveis == null || !notificaveis.Any())
                return notificavel;

            foreach (var item in notificaveis)
            {
                if (item.Invalido)
                    notificavel.AdicionarNotificacoes(notificavel.Notificacoes);
            }

            return notificavel;
        }
    }
}
