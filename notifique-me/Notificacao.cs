using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    /// <summary>
    /// Notificação
    /// </summary>
    public sealed class Notificacao
    {
        /// <summary>
        /// Identificador único da notificação (se necessário)
        /// </summary>
        public string Id { get; }

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
        /// <param name="id">Identificador único da notificação (opcional)</param>
        public Notificacao(string mensagem, string id = null)
        {
            this.Mensagem = mensagem;
            this.Id = id;
        }

        /// <summary>
        /// Cria uma notificação
        /// </summary>
        /// <param name="mensagem">Mensagem da notificação</param>
        /// <param name="informacoesAdicionais">Coleção de informações adicionais relacionadas a notificação.</param>
        /// <param name="id">Identificador único da notificação (opcional)</param>
        public Notificacao(string mensagem, Dictionary<string, string> informacoesAdicionais, string id = null)
        {
            this.Mensagem = mensagem;
            this.InformacoesAdicionais = informacoesAdicionais;
            this.Id = id;
        }
    }
}