using System.Collections.Generic;

namespace JNogueira.Infraestrutura.NotifiqueMe
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
        public static Notificavel NotificarSeVerdadeiro(this Notificavel notificavel, bool valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (valor)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor seja falso.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">Valor booleano a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeFalso(this Notificavel notificavel, bool valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!valor)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
    }
}
