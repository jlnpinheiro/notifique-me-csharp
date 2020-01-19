using System;
using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    public static partial class Notificar
    {
        /// <summary>
        /// Adiciona uma notificação caso uma determinada data seja maior que a data comparada.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorQue(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data > dataComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma determinada data seja maior ou igual a data comparada.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMaiorOuIgualA(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data >= dataComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma determinada data seja menor que a data comparada.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorQue(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data < dataComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma determinada data seja menor ou igual a data comparada.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeMenorOuIgualA(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data <= dataComparada)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma determinada data esteja entre duas outras datas
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataInicio">Data inicial do período a ser comparado.</param>
        /// <param name="dataFim">Data final do período a ser comparado.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeEntre(this INotificavel notificavel, DateTime data, DateTime dataInicio, DateTime dataFim, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data >= dataInicio && data <= dataFim)
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma data seja igual a outra.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeIguais(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (data.Equals(dataComparada))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }

        /// <summary>
        /// Adiciona uma notificação caso uma data seja diferente da outra.
        /// </summary>
        /// <param name="notificavel">Classe notificável</param>
        /// <param name="data">Data a ser verificada.</param>
        /// <param name="dataComparada">Data que será comparada.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <param name="informacoesAdicionais">Informações adicionais da notificação.</param>
        public static INotificavel NotificarSeDiferentes(this INotificavel notificavel, DateTime data, DateTime dataComparada, string mensagem, Dictionary<string, string> informacoesAdicionais = null)
        {
            if (notificavel == null)
                return null;

            if (!data.Equals(dataComparada))
                notificavel.AdicionarNotificacao(mensagem, informacoesAdicionais);

            return notificavel;
        }
    }
}