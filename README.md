# AzureTest
Testing azure deployment

Attempts:
1. ERROR: argument error: Connected registry name must use only lowercase. Need to change linked registry in azure..
2. Error with docker build due to context, looking for a way to change it.
3. Deployment successful, I can now see default weatherforecast. I want to do it with Helm next.
4. It's difficult the build doesn't find my images
5. Enough for today 2022-09-08. Todo: figure out why i'm (github actions broker?) unauthorized to pull the image.

2022-09-09 Trying again
1. Messing about with permissions in azure and trying different things. Feels like poking in the dark.
2. Was a helm values issue, now having some trouble with readiness probes but i think i'm close. Sharing values between helm and deployment job feels sluggish. Do I need an override for app version in the job?
3. Everything seems to be deployed correctly, I still don't like that my previuos deployment does not get overriden.
4. Ok everything seems to be overriden fine i think. 
Current workflow: 
* Make changes in main branch
* Merge master into dev (if Chart.yaml updated will build a new version, istead of overriding the old one)
* Githubactions detects the changes and pushes latest version (read from Chart.yaml).
Doing well, moving on to prisoners repo
