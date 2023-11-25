using CommunityToolkit.WinUI.Notifications;
using Octokit;
using System.Diagnostics;
using System.Reflection;

namespace IPv4.Services
{
    internal class Updater
    {
        private string _identifier;
        private string _owner;
        private string _project;

        internal Updater(string identifier, string owner, string project)
        {
            _identifier = identifier;
            _owner = owner;
            _project = project;

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                Process.Start(new ProcessStartInfo(args["url"]) { UseShellExecute = true });
            };
        }

        internal async Task CheckAsync()
        {
            GitHubClient ghClient = new GitHubClient(new ProductHeaderValue(_identifier));
            IReadOnlyList<Release> releases = await ghClient.Repository.Release.GetAll(_owner, _project);
            if (releases.Count == 0)
                return;

            Release latest = releases[0];
            Version online = new Version(latest.TagName.Replace("v", string.Empty));
            var current = Assembly.GetExecutingAssembly().GetName().Version;

            if (online > current)
            {
                new ToastContentBuilder()
                    .AddText("Nouvelle version disponible.")
                    .AddText($"Version {online}")
                    .AddButton(new ToastButton()
                        .SetContent("Télécharger")
                        .AddArgument("action", "openUrl")
                        .AddArgument("url", latest.HtmlUrl)
                    )
                    .Show();
            }
        }
    }
}
