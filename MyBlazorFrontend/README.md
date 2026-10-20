# WanderNest Travel & Tours — Cordova, Cebu

A frontend-only Blazor WebAssembly travel website using the existing `MyBlazorFrontend` project architecture and Tailwind CSS.

## Pages
- `/` — Home, featured Cordova-area destinations, sample packages, benefits, and sample testimonials.
- `/products` — Destinations, combined local search and filters, sorting, destination details, package details, and local-only sample booking validation.
- `/contact` — Fictional company contact details, inquiry form validation, and FAQs.

## Run locally
Open a terminal in this folder and run:

```bash
npm install
npm run build:css
dotnet watch
```

Use the local URL printed by `dotnet watch`. The project targets .NET 8 and keeps the existing Blazor WebAssembly setup.

## Important notes
- No backend, API, database, payment, or actual booking/inquiry submission is implemented.
- Booking and inquiry forms only validate locally in the browser.
- Prices, ratings, package details, testimonials, and business contact details are demonstration content.
- Images are remote representative photos; they may not depict the exact named location. Check current attraction access, local rules, weather, and operators before real travel.
- The development environment used to prepare this archive did not have the .NET SDK installed, so a `dotnet build` could not be run here. Run the commands above in an environment with .NET 8 installed.
