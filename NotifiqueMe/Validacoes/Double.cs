using System.Collections.Generic;

namespace JNogueira.Infraestrutura.NotifiqueMe
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
        public static Notificavel NotificarSeMaiorQue(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((double)numero > numeroComparado)
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
        public static Notificavel NotificarSeMaiorQue(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMaiorQue(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMaiorQue(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMaiorOuIgualA(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((double)numero >= numeroComparado)
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
        public static Notificavel NotificarSeMaiorOuIgualA(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMaiorOuIgualA(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMaiorOuIgualA(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (numero >= numeroComparado)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        #region MenorQue
        /// <summary>
        /// Adiciona uma notificação caso um determinado número seja menor que outro.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeMenorQue(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((double)numero < numeroComparado)
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
        public static Notificavel NotificarSeMenorQue(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMenorQue(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMenorQue(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMenorOuIgualA(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if ((double)numero <= numeroComparado)
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
        public static Notificavel NotificarSeMenorOuIgualA(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMenorOuIgualA(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeMenorOuIgualA(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeEntre(this Notificavel notificavel, double numero, double numeroInicio, double numeroFim, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeIguais(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (((double)numero).Equals(numeroComparado))
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
        public static Notificavel NotificarSeIguais(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        public static Notificavel NotificarSeIguais(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (((double)numero).Equals(numeroComparado))
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
        public static Notificavel NotificarSeIguais(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (((double)numero).Equals(numeroComparado))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
        #endregion

        #region Diferentes
        /// <summary>
        /// Adiciona uma notificação caso um numéro seja diferente de outro.
        /// </summary>
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeDiferentes(this Notificavel notificavel, decimal numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeDiferentes(this Notificavel notificavel, double numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeDiferentes(this Notificavel notificavel, float numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
        /// <param name="numero">Número a ser verificado.</param>
        /// <param name="numeroComparado">Número que será comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static Notificavel NotificarSeDiferentes(this Notificavel notificavel, int numero, double numeroComparado, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
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
