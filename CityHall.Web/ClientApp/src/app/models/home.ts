export interface Home {

    widgets: WidgetItem[];

}
export interface WidgetItem {
    widget: Widget;
    index?: number;
    preRenderedItem?: number;
    showLoadMoreButton?: boolean;
    source?: string;
    background: string;
    header: string; 

}

export enum Widget {
    Carousel, 
    Card, 
    SmallCard, 
    Tag

}

