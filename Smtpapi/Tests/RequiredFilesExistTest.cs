namespace SendGrid.Tests
{
    using System;
    using Xunit;

    public class TestRequiredFilesExist
    {

        // ./Docker or docker/Docker
        public void checkDockerExists()
        {
            bool dockerExists = File.Exists("./Dockerfile") ||
            File.Exists("./docker/Dockerfile");
            Assert.True(dockerExists);
        }

        // ./docker-compose.yml or ./docker/docker-compose.yml
        public void checkDockerComposeExists()
        {
            bool dockerComposeExists = File.Exists("./docker-compose.yml") ||
            File.Exists("./docker/docker-compose.yml");
            Assert.True(dockerComposeExists);
        }

        // ./.env_sample
        public void checkEnvSampleExists()
        {
            Assert.True(File.Exists("./.env_sample"));
        }

        // ./.gitignore
        public void checkGitIgnoreExists()
        {
            Assert.True(File.Exists("./.gitignore"));
        }

        // ./.travis.yml
        public void checkTravisExists()
        {
            Assert.True(File.Exists("./.travis.yml"));
        }

        // ./.codeclimate.yml
        public void checkCodeClimateExists()
        {
            Assert.True(File.Exists("./.codeclimate.yml"));
        }

        // ./CHANGELOG.md
        public void checkChangelogExists()
        {
            Assert.True(File.Exists("./CHANGELOG.md"));
        }

        // ./CODE_OF_CONDUCT.md
        public void checkCodeOfConductExists()
        {
            Assert.True(File.Exists("./CODE_OF_CONDUCT.md"));
        }

        // ./CONTRIBUTING.md
        public void checkContributingGuideExists()
        {
            Assert.True(File.Exists("./CONTRIBUTING.md"));
        }

        // ./ISSUE_TEMPLATE.md
        public void checkIssuesTemplateExists()
        {
            Assert.True(File.Exists("./ISSUE_TEMPLATE.md"));
        }

        // ./LICENSE.md
        public void checkLicenseExists()
        {
            Assert.True(File.Exists("./LICENSE.md"));
        }

        // ./PULL_REQUEST_TEMPLATE.md
        public void checkPullRequestExists()
        {
            Assert.True(File.Exists("./PULL_REQUEST_TEMPLATE.md"));
        }

        // ./README.md
        public void checkReadMeExists()
        {
            Assert.True(File.Exists("./README.md"));
        }

        // ./TROUBLESHOOTING.md
        public void checkTroubleShootingGuideExists()
        {
            Assert.True(File.Exists("./TROUBLESHOOTING.md"));
        }

        // ./USAGE.md
        public void checkUsageGuideExists()
        {
            Assert.True(File.Exists("./USAGE.md"));
        }

        // ./USE_CASES.md
        public void checkUseCases()
        {
            Assert.True(File.Exists("./UseCases/README.md"));
        }
    }
}
