import { Document, Editor, Tag } from "./shared";
export interface Detail{
    title?: string;
    briefDescription?: string;
    date?: Date;
    createdAt?: Date;
    updatedAt?: Date;
    readingTime?: number;
    imageUrl?: string;
    captionImage?: string;  
    htmlContent?: string;
    documents?: Document[];
    topics?: Tag[];
    editedBy?: Editor;  
}