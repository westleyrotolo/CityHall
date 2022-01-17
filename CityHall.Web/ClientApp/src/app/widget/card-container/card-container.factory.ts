import { ComponentFactory, ComponentFactoryResolver, ComponentRef, ViewContainerRef } from "@angular/core";
import { Card } from "src/app/models/card";
import { CardContainerComponent } from "./card-container.component";

export class CardContainerFactory {

    static Create(resolver: ComponentFactoryResolver, container : ViewContainerRef, cards: Card[]) : ComponentRef<CardContainerComponent> {

        const factory: ComponentFactory<CardContainerComponent> = resolver.resolveComponentFactory(CardContainerComponent)
        let componentRef = container.createComponent(factory);
        componentRef.instance.cards = cards
        return componentRef;
    }
}
