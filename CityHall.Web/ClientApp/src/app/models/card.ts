import { Category, Link, Tag } from "./shared";

export interface Card {
    image?: string;
    date? : Date;
    title: string;
    content?: string;
    link?: Link;
    tags?: Tag[];
    category?: Category;
}