using System.Collections.Generic;

namespace JNogueira.NotifiqueMe
{
    public interface INotificavel
    {
        bool Invalido { get; }
        IReadOnlyCollection<string> Mensagens { get; }
        IReadOnlyCollection<Notificacao> Notificacoes { get; }

        void AdicionarNotificacao(Notificacao notificacao);
        void AdicionarNotificacao(string mensagem, string id = null);
        void AdicionarNotificacao(string mensagem, Dictionary<string, string> informacoesAdicionais, string id = null);
        void AdicionarNotificacoes(IReadOnlyCollection<Notificacao> notificacoes);
        void AdicionarNotificacoes(Notificavel notificavel);
        void AdicionarNotificacoes(params Notificavel[] notificaveis);
    }
}