# AVIV technical test solution

You can use this file to write down your assumptions and list the missing features or technical revamp that should
be achieved with your implementation.

## Notes

Write here notes about your implementation choices and assumptions.
I ve decided to use the same choices of the current project when it comes to naming properties or architectural decisions.

In addition I ve included a created_date at api to inform when the price changes.

I ve also saw that when there is only one record in Listings there are no price history yet.
But when we change the price so there is a new record to be inserted in Prices 

## Questions

This section contains additional questions your expected to answer before the debrief interview.

- **What is missing with your implementation to go to production?**
unit tests, I really miss them
and bothering me work with int ids, I think that this can cause a botleneck when more than one request comes in parallel. (so I rather be using Guids created on the fly during request, and not at database like auto-inc int)

- **How would you deploy your implementation?**
I ve ran it in a private aks cluster
I ve included two files `deployment.yml` and `service.yml` I used them to deploy
here I am uploading them with fake credentials 

- **If you had to implement the same application from scratch, what would you do differently?**
I would created a separated layer for business objects (Domain)
and I would not place my business rules at controllers, I would use an application service instead (each method should correspond to a user case) inside application services there will be domain object calls and repository calls.

and business decisions should be inside Domain/business objects


- **The application aims at storing hundreds of thousands listings and millions of prices, and be accessed by millions
  of users every month. What should be anticipated and done to handle it?**
  
  change the ids for guids, and implement pagination for apis, and an extra cache layer for reading

  NB : You can update the [given architecture schema](./schemas/Aviv_Technical_Test_Architecture.drawio) by importing it
  on [diagrams.net](https://app.diagrams.net/) 
