﻿using System;
using System.Collections.Generic;

namespace ProjectKIssueList.Models
{
    public class RepoSetDefinition
    {
        public RepoDefinition[] Repos { get; set; }

        public string AssociatedPersonSetName { get; set; }
    }

    public class StaticRepoSetProvider : IRepoSetProvider
    {
        private static readonly Dictionary<string, RepoSetDefinition> RepoSetList = new Dictionary<string, RepoSetDefinition>(StringComparer.OrdinalIgnoreCase)
        {
            {
                "kcore",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "Murat",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("aspnet", "aspnet-docker"),
                        new RepoDefinition("aspnet", "aspnet-win-docker"),
                        new RepoDefinition("aspnet", "BasicMiddleware"),
                        new RepoDefinition("aspnet", "Caching"),
                        new RepoDefinition("aspnet", "Coherence"),
                        new RepoDefinition("aspnet", "Coherence-Signed"),
                        new RepoDefinition("aspnet", "CoreCLR"),
                        new RepoDefinition("aspnet", "DataProtection"),
                        new RepoDefinition("aspnet", "dnvm"),
                        new RepoDefinition("aspnet", "dnx"),
                        new RepoDefinition("aspnet", "dnx-watch"),
                        new RepoDefinition("aspnet", "Entropy"),
                        new RepoDefinition("aspnet", "FileSystem"),
                        new RepoDefinition("aspnet", "Helios"),
                        new RepoDefinition("aspnet", "homebrew-dnx"),
                        new RepoDefinition("aspnet", "Hosting"),
                        new RepoDefinition("aspnet", "HttpAbstractions"),
                        new RepoDefinition("aspnet", "HttpClient"),
                        new RepoDefinition("aspnet", "IISIntegration"),
                        new RepoDefinition("aspnet", "KestrelHttpServer"),
                        new RepoDefinition("aspnet", "libuv-build"),
                        new RepoDefinition("aspnet", "Logging"),
                        new RepoDefinition("aspnet", "Proxy"),
                        new RepoDefinition("aspnet", "ResponseCaching"),
                        new RepoDefinition("aspnet", "Roslyn"),
                        new RepoDefinition("aspnet", "Security"),
                        new RepoDefinition("aspnet", "ServerTests"),
                        new RepoDefinition("aspnet", "Session"),
                        new RepoDefinition("aspnet", "Setup"),
                        new RepoDefinition("aspnet", "Signing"),
                        new RepoDefinition("aspnet", "StaticFiles"),
                        new RepoDefinition("aspnet", "Universe"),
                        new RepoDefinition("aspnet", "UserSecrets"),
                        new RepoDefinition("aspnet", "WebListener"),
                        new RepoDefinition("aspnet", "WebSockets"),
                    },
                }
            },
            {
                "mvc",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "Eilon",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("aspnet", "Antiforgery"),
                        new RepoDefinition("aspnet", "aspnet.xunit"),
                        new RepoDefinition("aspnet", "Common"),
                        new RepoDefinition("aspnet", "CORS"),
                        new RepoDefinition("aspnet", "DependencyInjection"),
                        new RepoDefinition("aspnet", "Diagnostics"),
                        new RepoDefinition("aspnet", "DnxTools"),
                        new RepoDefinition("aspnet", "EventNotification"),
                        new RepoDefinition("aspnet", "jquery-ajax-unobtrusive"),
                        new RepoDefinition("aspnet", "jquery-validation-unobtrusive"),
                        new RepoDefinition("aspnet", "JsonPatch"),
                        new RepoDefinition("aspnet", "Localization"),
                        new RepoDefinition("aspnet", "MusicStore"),
                        new RepoDefinition("aspnet", "Mvc"),
                        new RepoDefinition("aspnet", "PackageSearch"),
                        new RepoDefinition("aspnet", "Razor"),
                        new RepoDefinition("aspnet", "RazorTooling"),
                        new RepoDefinition("aspnet", "Routing"),
                        new RepoDefinition("aspnet", "Testing"),
                    },
                }
            },
            {
                "data",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "Diego",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("aspnet", "Configuration"),
                        new RepoDefinition("aspnet", "EntityFramework"),
                        new RepoDefinition("aspnet", "EntityFramework.Docs"),
                        new RepoDefinition("aspnet", "Identity"),
                        new RepoDefinition("aspnet", "Microsoft.Data.Sqlite"),
                        new RepoDefinition("aspnet", "Options"),
                        new RepoDefinition("aspnet", "SqlClient"),
                    },
                }
            },
            {
                "pm",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("aspnet", "Docs"),
                        new RepoDefinition("aspnet", "Docs-internal"),
                        new RepoDefinition("aspnet", "Home"),
                        new RepoDefinition("aspnet", "NerdDinner"),
                    },
                }
            },
            {
                "engineering",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("aspnet", "Announcements"),
                        new RepoDefinition("aspnet", "BugTracker"),
                        new RepoDefinition("aspnet", "EndToEnd"),
                        new RepoDefinition("aspnet", "External"),
                        new RepoDefinition("aspnet", "IBC"),
                        new RepoDefinition("aspnet", "kbot"),
                        new RepoDefinition("aspnet", "KExpense"),
                        new RepoDefinition("aspnet", "MusicStore-Authorization"),
                        new RepoDefinition("aspnet", "Perf"),
                        new RepoDefinition("aspnet", "Performance"),
                        new RepoDefinition("aspnet", "Reporting"),
                        new RepoDefinition("aspnet", "specs"),
                        new RepoDefinition("aspnet", "Stress"),
                        new RepoDefinition("aspnet", "TeamCityTrigger"),
                    },
                }
            },
            {
                "nuget",
                new RepoSetDefinition {
                    AssociatedPersonSetName = "",
                    Repos = new RepoDefinition[] {
                        new RepoDefinition("nuget", "Concierge"),
                        new RepoDefinition("nuget", "Entropy"),
                        new RepoDefinition("nuget", "Home"),
                        new RepoDefinition("nuget", "json-ld.net"),
                        new RepoDefinition("nuget", "Media"),
                        new RepoDefinition("nuget", "NuGetGallery"),
                        new RepoDefinition("nuget", "NuGetStats"),
                        new RepoDefinition("nuget", "nuget.github.com"),
                        new RepoDefinition("nuget", "NuGet.Jobs"),
                        new RepoDefinition("nuget", "NuGet.Operations"),
                        new RepoDefinition("nuget", "NuGet.PackageIndex"),
                        new RepoDefinition("nuget", "NuGet.Schema"),
                        new RepoDefinition("nuget", "NuGet.Services.Build"),
                        new RepoDefinition("nuget", "NuGet.Services.Dashboard"),
                        new RepoDefinition("nuget", "NuGet.Services.Gateway"),
                        new RepoDefinition("nuget", "NuGet.Services.Messaging"),
                        new RepoDefinition("nuget", "NuGet.Services.Metrics"),
                        new RepoDefinition("nuget", "OpsDashboard"),
                        new RepoDefinition("nuget", "PoliteCaptcha"),
                        new RepoDefinition("nuget", "Samples"),
                        new RepoDefinition("nuget", "WebBackgrounder"),
                    },
                }
            },
        };

        public IDictionary<string, RepoSetDefinition> GetRepoSetLists()
        {
            return RepoSetList;
        }

        public RepoSetDefinition GetRepoSet(string repoSet)
        {
            return RepoSetList[repoSet];
        }

        public bool RepoSetExists(string repoSet)
        {
            return RepoSetList.ContainsKey(repoSet);
        }
    }
}
