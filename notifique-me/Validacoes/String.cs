using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JNogueira.NotifiqueMe
{
    public static partial class Notificar
    {
        /// <summary>
        /// Adiciona uma notificação caso o valor seja nulo ou vazio.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeNuloOuVazio(this INotificavel notificavel, string valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor não seja nulo ou vazio.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeNaoNuloOuVazio(this INotificavel notificavel, string valor, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!string.IsNullOrEmpty(valor))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor possua a quantidade de caracteres superior a um determinado limite.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="limite">Quantidade limite de caracteres.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSePossuirTamanhoSuperiorA(this INotificavel notificavel, string valor, int limite, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor.Length > limite)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor possua a quantidade de caracteres inferior a um determinado limite.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="limite">Quantidade limite de caracteres.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSePossuirTamanhoInferiorA(this INotificavel notificavel, string valor, int limite, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor.Length < limite)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor possua a quantidade de caracteres diferente de um determinado valor.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="quantidade">Quantidade de caracteres a ser verificado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSePossuirTamanhoDiferente(this INotificavel notificavel, string valor, int quantidade, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor.Length != quantidade)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor contenha uma determinada string.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="stringProcurada">String que será procurada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeContem(this INotificavel notificavel, string valor, string stringProcurada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor.Contains(stringProcurada))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor não contenha uma determinada string.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="stringProcurada">String que será procurada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeNaoContem(this INotificavel notificavel, string valor, string stringProcurada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || !valor.Contains(stringProcurada))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor seja igual a determinada string.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="stringComparada">String que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, string valor, string stringComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor == stringComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor seja diferente a determinada string.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="stringComparada">String que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, string valor, string stringComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || valor != stringComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o valor informado não seja validado pela expressão regular informada.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="valor">String a ser verificada.</param>
        /// <param name="expressaoRegular">Expressão regular utilizada para validar.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeExpressaoRegularNaoValida(this INotificavel notificavel, string valor, string expressaoRegular, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (string.IsNullOrEmpty(valor) || !Regex.IsMatch(valor, expressaoRegular))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso o e-mail seja inválido.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="email">E-mail a ser validado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeEmailInvalido(this INotificavel notificavel, string email, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            return NotificarSeExpressaoRegularNaoValida(notificavel, email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", mensagem, informacoesAdicionais);
        }

        /// <summary>
        /// Adiciona uma notificação caso a URL seja inválida.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="url">URL a ser validada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeUrlInvalida(this INotificavel notificavel, string url, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            return NotificarSeExpressaoRegularNaoValida(notificavel, url, @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", mensagem, informacoesAdicionais);
        }
    }
}
