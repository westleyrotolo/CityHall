import { FollowUs, HyperLink, Link, Section } from "./shared";

export interface Footer {
    hasNewsletter?: boolean;
    sections?: Section[];
    followUs?: FollowUs[];
    logo?: string;
    cityTitle?: string;
    citySubtitle?: string;
    footerItem?: FooterItem;
    contacts?: Contacts;
    usefulLinksSection?: HyperLink[]
}

export interface FooterItem{
    title: HyperLink;
    content: string;
}


export interface Contacts {
    content: String;
    links?: HyperLink[]
}