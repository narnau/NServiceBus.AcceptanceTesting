# NServiceBus.AcceptanceTesting
> Example of using NServiceBus AcceptanceTesting Library in a simple scenario

## Scenario

In this scenario, the SALES endPoint receives the command "RegisterOrder".
The endPoint processes it and send another command called "OtherOrder". It is received by
the SALES endPoint itself. Then, this endPoint publishes an event called "OrderAccepted"
that is received by the same endPoint.

This scenario is useful to perform integration tests in a scenario where some aggregates
are communicated via servicebus in the same process.
```html
                                   _  _ _ _ _ _ _ _ _ _ _ _
                                  |                        |
                     |---------------------|--OtherOrder--->
RegisterOrder -----> |  SALES   endPoint   |  
                     |---------------------|--OrderAccepted -->
                                    | _ _ _ _ _ _ _ _ _ _ _ _ |
```

Reference: https://github.com/roycornelissen/NServiceBus.AcceptanceTesting.Sample
