import { createContext, useContext, useState, useEffect } from "react";
const CapsContext = createContext();

export const CapsProvider = ({ children }) => {
    const [capsList, setCapsList] = useState();
    useEffect(() => {
        fetch("https://api.imgflip.com/get_memes")
            .then((res) => res.json())
            .then((res) => setCapsList(res.data.memes));
    }, []);
    const getMemeById = (id) => {
        if (capsList) {
            return capsList.find((meme) => meme.id === id);
        } else {
            throw console.error("capslist not found");
        }
    };
    return (
        <CapsContext.Provider value={{ capsList, setCapsList, getMemeById }}>
            {children}
        </CapsContext.Provider>
    );
};
export const useCapsContext = () => useContext(CapsContext);
