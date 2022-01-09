export interface FollowUs {
    url: string;
    name: string;
    icon: string;
}

export interface Section {
    name: string;
    link: Link;
    items?: SectionItem[];
}

export interface SectionItem {
    name: string;
    link: Link;
}

export interface HyperLink {
    title: string;
    link: Link;
}
export interface Link {
    linkType: LinkType;
    externalLink?: string;
    linkedPageId?: string;
}

export interface Tag{
    title: string;
}

export enum LinkType {
    None,
    Internal, 
    External
}

export interface Category {
    title: string;
}