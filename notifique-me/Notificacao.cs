using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    /// <summary>
    /// Notificação
    /// </summary>
    public sealed class Notificacao
    {
        /// <summary>
        /// Mensagem da notificação
        /// </summary>
        public string Mensagem { get; }

        /// <summary>
        /// Conjunto de informações adicionais associadas a notificação
        /// </summary>
        public Dictionary<string, string> InformacoesAdicionais { get; }

        /// <summary>
        /// Cria uma notificação
        /// </summary>
        /// <param name="mensagem">Mensagem da notificação</param>
        public Notificacao(string mensagem)
        {
            this.Mensagem = mensagem;
        }

        /// <summary>
        /// Cria uma notificação
        /// </summary>
        /// <param name="mensagem">Mensagem da notificação</param>
        /// <param name="informacoesAdicionais">Coleção de informações adicionais relacionadas a notificação.</param>
        public Notificacao(string mensagem, Dictionary<string, string> informacoesAdicionais)
        {
            this.Mensagem = mensagem;
            this.InformacoesAdicionais = informacoesAdicionais;
        }
    }
}