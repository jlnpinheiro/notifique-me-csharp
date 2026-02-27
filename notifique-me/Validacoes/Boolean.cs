using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    public static partial class Notificar
    {
        /// <summary>
        /// Adiciona uma notificação caso o valor seja verdadeiro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">Valor booleano a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        /// <param name="id">Identificador da notificação.</param>
        public static INotificavel NotificarSeVerdadeiro(this INotificavel notificavel, bool valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null, string id = null)
        {
            if (notificavel == null)
                return null;

            if (valor)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais, id);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor seja falso.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">Valor booleano a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        /// <param name="id">Identificador da notificação.</param>
        public static INotificavel NotificarSeFalso(this INotificavel notificavel, bool valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null, string id = null)
        {
            if (notificavel == null)
                return null;

            if (!valor)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais, id);

            return notificavel;
        }
    }
}
