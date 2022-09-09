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
2. Was a helm values issue, now having some trouble with readiness probes but i think i'm close. Sharing values between helm and depoyment feels sluggish.
