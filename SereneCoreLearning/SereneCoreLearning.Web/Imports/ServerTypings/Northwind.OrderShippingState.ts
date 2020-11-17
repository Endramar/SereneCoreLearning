﻿namespace SereneCoreLearning.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'SereneCoreLearning.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
