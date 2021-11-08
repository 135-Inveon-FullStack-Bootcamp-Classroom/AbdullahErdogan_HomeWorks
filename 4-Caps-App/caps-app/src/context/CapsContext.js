import { createContext, useContext, useState } from "react";
const CapsContext = createContext();

export const CapsProvider = ({ children }) => {
    const [capsList, setCapsList] = useState();
    return (
        <CapsContext.Provider value={{ capsList, setCapsList }}>
            {children}
        </CapsContext.Provider>
    );
};
export const useCapsContext = () => useContext(CapsContext);
