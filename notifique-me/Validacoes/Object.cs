using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{ 
    public static partial class Notificar
    {
        /// <summary>
        /// Adiciona uma notificação caso o objeto seja nulo
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="objeto">Objeto a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeNulo(this INotificavel notificavel, object objeto, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (objeto == null)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o objeto não seja nulo
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="objeto">Objeto a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeNaoNulo(this INotificavel notificavel, object objeto, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (objeto != null)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um objeto seja igual ao outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="obj1">Objeto a ser verificado.</param>
        /// <param name="obj2">Objeto que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, object obj1, object obj2, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (obj1.Equals(obj2))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um objeto seja diferente ao outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="obj1">Objeto a ser verificado.</param>
        /// <param name="obj2">Objeto que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, object obj1, object obj2, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!obj1.Equals(obj2))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
    }
}
