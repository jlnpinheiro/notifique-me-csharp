using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    public static partial class Notificar
    {
        #region MaiorQue
        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorQue(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((float)numero > numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorQue(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero > numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorQue(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero > numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorQue(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero > numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        #region MaiorOuIgualA
        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorOuIgualA(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((float)numero >= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorOuIgualA(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero >= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorOuIgualA(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero >= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja maior ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorOuIgualA(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero >= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        # region MenorQue
        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorQue(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((float)numero < numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorQue(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero < numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorQue(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero < numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorQue(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero < numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        #region MenorOuIgualA
        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorOuIgualA(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((float)numero <= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorOuIgualA(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero <= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorOuIgualA(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero <= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor ou igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorOuIgualA(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero <= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        /// <summary>
        /// Adiciona uma notificação caso um determinado número esteja entre dois outros números
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Data a ser verificada.</param>
        /// <param name="numeroInicio">Número inicial do período a ser comparado.</param>
        /// <param name="numeroFim">Número final do período a ser comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeEntre(this INotificavel notificavel, float numero, float numeroInicio, float numeroFim, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero >= numeroInicio && numero <= numeroFim)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        #region Iguais
        /// <summary>
        /// Adiciona uma notificação caso um numéro seja igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (((float)numero).Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero.Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero.Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja igual a outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (((float)numero).Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        #region Diferentes
        /// <summary>
        /// Adiciona uma notificação caso um numéro seja diferente de outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, decimal numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!((float)numero).Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja diferente de outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, double numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!numero.Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja diferente de outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, float numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!numero.Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso um numéro seja diferente de outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, int numero, float numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!numero.Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion
    }
}
