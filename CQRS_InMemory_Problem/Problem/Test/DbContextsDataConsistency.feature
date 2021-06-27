Feature: DbContextsDataConsistency

Scenario: InsertAndGetSample
Given Sample Write Model With Name "Mehdi" And Code "23445F" And ID "10" In The Write Model
When Sample With ID "10" Fetched From Read Model
Then The Fetched Sample Read Model's Username shoud be "Mehdi"